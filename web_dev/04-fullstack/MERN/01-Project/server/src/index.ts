import express, {Request, Response, Router, json} from "express";
import mongoose from "mongoose";
import dotenv from "dotenv";
import cors from "cors";
import userInfo from "./models/login-signup";

dotenv.config();
const app = express();
const PORT = process.env.PORT || 5000;

app.use(express.json());
app.use(cors({
   origin: "*",
}));

const db = mongoose.connect(process.env.MONGO_URI as string)
.then(() => {
   console.log("DB connected");
}).catch((err) => {
   console.log(err.message);
});

app.get("/home", (req:Request, res:Response) => {
   res.send("Hello User");
});

app.post("/signup", async (req:Request, res:Response) => {
   await userInfo.signUp(req, res);
});

app.post("/login", async (req:Request, res:Response) => {
   await userInfo.login(req, res);
});



app.listen(PORT, () => {
   console.log(`Server is running on port ${PORT}`);
});