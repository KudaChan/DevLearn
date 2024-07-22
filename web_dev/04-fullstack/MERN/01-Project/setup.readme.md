# for client

npm create vite@latest foldername

npm install
npm run dev

---

# for server(express)

npm init -f
npm install express --save // npm i --save express

npm i --save-dev ts-node (to run type script)

# nodemon setup 

npm install --save-dev nodemon

in  package.json
 set "script": {
   "dev": "nodemon -- watch \"src/**\" --ext \"ts,json\" --exec \"ts-node src/index.ts\""
 }