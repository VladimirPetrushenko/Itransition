const fs = require('fs')
const  { SHA3 } = require("sha3/index.js")
 
const readFile = f => new Promise( (resolve, reject) => {
    const readStream = fs.createReadStream(f, {highWaterMark: 256*256 });
    
    const data = []
    readStream.on('data', (chunk) => {
        data.push(chunk)
    })
 
    readStream.on('end', () => {
        resolve(data)
    })
    
    readStream.on('error', (err) => {
        reject(err)
    })
})
 
const getHash = (entry, data) => {
    const hash = new SHA3(256).update(Buffer.concat(data));
    console.log(entry, hash.digest('hex'))
}
 
const procEntry = async entry =>{
    let statEntry = fs.statSync( entry)
    if(statEntry.isFile()){
        try{
            let data = await readFile(entry)
            getHash(entry, data)
        }
        catch(e){
            console.log(e)
        }
    }
}
 
try{
    for(let entry of fs.readdirSync(process.cwd())) {
        procEntry(entry)
    }
}
catch(e){
    console.error(e.message)
}