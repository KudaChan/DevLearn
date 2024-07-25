import express, { Request, Response } from "express";
import dotenv from "dotenv";
import crud from "./models/crud";
import cors from "cors";
// import pg from "pg";

const api = express();
dotenv.config();
api.use(cors());
api.use(express.json());
api.use(express.urlencoded({ extended: true }));

// // pg connection
// const db = new pg.Pool({
//    user: "kumar",
//    password: "chan05dan",
//    host: "localhost",
//    port: 5432,
//    database: "form",
// });


api.get("/", (req: Request, res: Response) => {
   res.json({ message: "Hello World" });
});

api.post("/form", async (req: Request, res: Response) => {
   // console.log('received post /form request');
   // console.log('Request body:', req.body);
   const formData = {
      firstName: req.body.firstname,
      middleName: req.body.middlename,
      lastName: req.body.lastname,
      phone: req.body.mobile,
      email: req.body.email,
      dob: req.body.birthdate,
      gender: req.body.gender,
      fatherFirstName: req.body.fatherfirstname,
      fatherMiddleName: req.body.fathermiddlename,
      fatherLastName: req.body.fatherlastname,
      fatherPhone: req.body.fathermobile,
      fatherEmail: req.body.fatheremail,
      fatherOccupation: req.body.fatheroccupation,
      motherFirstName: req.body.motherfirstname,
      motherMiddleName: req.body.mothermiddlename,
      motherLastName: req.body.motherlastname,
      motherPhone: req.body.mothermobile,
      motherEmail: req.body.motheremail,
      motherOccupation: req.body.motheroccupation,
      houseNo: req.body.houseno,
      street: req.body.street,
      city: req.body.city,
      state: req.body.state,
      zipCode: req.body.zipcode,
      country: req.body.country,
      about: req.body.about,
      declaration: req.body.declaration,
      consent: req.body.consent,
   };
   try {
      const data = await crud.create(formData);
      const formId = data?.formId;
      res.json({ formId: formId });
   } catch (err) {
      res.status(500).json({ message: "Internal Server Error" });
   }
});

api.get("/form/data", async (req: Request, res: Response) => {
   const data = await crud.readAll();
   if (data) {
      res.json(data.entriesInfo);
      res.json({ totalForms: data.totalForms });
   } else {
      res.status(404).json({ message: "No data found" });
   }
});

api.get("/form/data/:id", async (req: Request, res: Response) => {
   const { id } = req.params;
   try {
      const data = await crud.readByFormId(id);
      if (data) {
         res.json(data);
      } else {
         res.status(404).json({ message: "Form not found" });
      }
   } catch (err) {
      res.status(500).json({ error: err });
   }
});

api.delete("/form/data/delete/:id", async (req: Request, res: Response) => {
   const { id } = req.params;
   await crud.deleteByFormId(id);
   res.json({ message: "Form deleted" });
});

api.listen(5000, () => {
   console.log("Server is running on port 5000");
});
