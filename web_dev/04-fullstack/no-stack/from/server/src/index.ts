import express, { Request, Response } from "express";
import dotenv from "dotenv";
import mongoose from "mongoose";
import cors from "cors";
import crud from "./models/crud";

const api = express();
dotenv.config();
api.use(cors());
api.use(express.json());
api.use(express.urlencoded({ extended: true }));

const db = mongoose
   .connect(process.env.MONGO_URI as string)
   .then(() => console.log("MongoDB connected"))
   .catch((err) => console.log(err));

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
      mobileNumber: req.body.mobile,
      email: req.body.email,
      birthDate: req.body.birthdate,
      gender: req.body.gender,
      fatherFirstName: req.body.fatherfirstname,
      fatherMiddleName: req.body.fathermiddlename,
      fatherLastName: req.body.fatherlastname,
      fatherMobileNumber: req.body.fathermobile,
      fatherEmail: req.body.fatheremail,
      fatherOccupation: req.body.fatheroccupation,
      motherFirstName: req.body.motherfirstname,
      motherMiddleName: req.body.mothermiddlename,
      motherLastName: req.body.motherlastname,
      motherMobileNumber: req.body.mothermobile,
      motherEmail: req.body.motheremail,
      motherOccupation: req.body.motheroccupation,
      houseNumber: req.body.houseno,
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
      const data = await crud.saveForm(formData);
      const formId = data?._formId;
      res.json({ formId: formId });
   } catch (err) {
      res.status(500).json({ message: "Internal Server Error" });
   }
});

// api.get('/form/data/:id', async (req: Request, res: Response) => {
//    const data = await crud.getFormById(req.params.id);
//    if (data) {
//       res.json(data);
//    } else {
//       res.status(404).json({ message: 'Form not found' });
//    }
// });

api.get("/form/data", async (req: Request, res: Response) => {
   const data = await crud.getForm();
   if (data) {
      const formData = data.map((item: any) => {
         return {
            formId: item._formId,
            firstName: item.personalInfo.firstName,
            lastName: item.personalInfo.lastName,
            mobileNumber: item.personalInfo.mobileNumber,
            email: item.personalInfo.email,
         };
      });
      res.json({
         formData: formData,
         totalForms: data.length,
      });
   } else {
      res.json({ message: "No data found" });
   }
});

api.get("/form/data/:id", async (req: Request, res: Response) => {
   const { id } = req.params;
   try {
      const data = await crud.getFormById(id);
      if (data) {
         res.json(data);
      } else {
         res.status(404).json({ message: "Form not found" });
      }
   } catch (err) {
      res.status(500).json({ error: err });
   }
});

api.listen(5000, () => {
   console.log("Server is running on port 5000");
});
