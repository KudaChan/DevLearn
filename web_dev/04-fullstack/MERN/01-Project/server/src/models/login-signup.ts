import { Request, Response } from "express";
import db from "./db";

const signUp = async (req: Request, res: Response) => {
   const { username, email, password } = req.body;

   // Log the incoming request body
   console.log("Request Body:", req.body);

   // Validate the incoming data
   if (!username || !email || !password) {
      return res.status(400).json({ message: "All fields are required" });
   }

   try {
      const saveUser = await db.saveUser(username, email, password);
      if (saveUser) {
         return res.status(200).json(saveUser);
      } else {
         return res.status(400).json({ message: "User not saved" });
      }
   } catch (error) {
      return res.status(500).json({ message: "Internal server error" });
   }
};

const login = async (req: Request, res: Response) => {
   const { email, password } = req.body;

   // Log the incoming request body
   console.log("Request Body:", req.body);

   // Validate the incoming data
   if (!email || !password) {
      return res.status(400).json({ message: "Email and password are required" });
   }

   try {
      const findUser = await db.getUserByMail(email, password);
      if (findUser) {
         return res.status(200).json(findUser);
      } else {
         return res.status(400).json({ message: "User not found" });
      }
   } catch (error) {
      return res.status(500).json({ message: "Internal server error" });
   }
};

export default { signUp, login };