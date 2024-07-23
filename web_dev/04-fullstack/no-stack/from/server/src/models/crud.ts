import mongoose, { Schema } from 'mongoose';
import { v4 as uuidv4 } from 'uuid';

const schema = mongoose.Schema;
const ObjectId = Schema.ObjectId;

const formSchema = new schema({
   _formId: { type: String, required: true, default: uuidv4() },
   personalInfo: {
      firstName: { type: String, required: true },
      middleName: { type: String, required: false },
      lastName: { type: String, required: true },
      mobileNumber: { type: String, required: true },
      email: { type: String, required: true },
      birthDate: { type: Date, required: true },
      gender: { type: String, required: true },
   },
   parentInfo: {
      fatherFirstName: { type: String, required: true },
      fatherMiddleName: { type: String, required: false },
      fatherLastName: { type: String, required: true },
      fatherMobileNumber: { type: String, required: true },
      fatherEmail: { type: String, required: true },
      fatherOccupation: { type: String, required: true },
      motherFirstName: { type: String, required: true },
      motherMiddleName: { type: String, required: false },
      motherLastName: { type: String, required: true },
      motherMobileNumber: { type: String, required: true },
      motherEmail: { type: String, required: true },
      motherOccupation: { type: String, required: true },
   },
   addressInfo: {
      houseNumber: { type: String, required: true },
      street: { type: String, required: true },
      city: { type: String, required: true },
      state: { type: String, required: true },
      zipCode: { type: String, required: true },
      country: { type: String, required: true },
   },
   additionalInfo: {
      about: { type: String, required: true },
      declaration: { type: Boolean, required: true },
      consent: { type: Boolean, required: true },
   },
});

const Form = mongoose.model('Form', formSchema);

// save form data in database
const saveForm = async (form: any) => {
   try {
      const formData = new Form({
         _formId: uuidv4(),
         personalInfo: {
            firstName: form.firstName,
            middleName: form.middleName,
            lastName: form.lastName,
            mobileNumber: form.mobileNumber,
            email: form.email,
            birthDate: form.birthDate,
            gender: form.gender,
         },
         parentInfo: {
            fatherFirstName: form.fatherFirstName,
            fatherMiddleName: form.fatherMiddleName,
            fatherLastName: form.fatherLastName,
            fatherMobileNumber: form.fatherMobileNumber,
            fatherEmail: form.fatherEmail,
            fatherOccupation: form.fatherOccupation,
            motherFirstName: form.motherFirstName,
            motherMiddleName: form.motherMiddleName,
            motherLastName: form.motherLastName,
            motherMobileNumber: form.motherMobileNumber,
            motherEmail: form.motherEmail,
            motherOccupation: form.motherOccupation,
         },
         addressInfo: {
            houseNumber: form.houseNumber,
            street: form.street,
            city: form.city,
            state: form.state,
            zipCode: form.zipCode,
            country: form.country,
         },
         additionalInfo: {
            about: form.about,
            declaration: form.declaration,
            consent: form.consent,
         },
      });
      console.log(formData);
      await formData.save();
      return formData;
   } catch (error) {
      console.log(error);
      return null;
   }
};

// get form data from database
const getForm = async () => {
   try {
      const formData = await Form.find().limit(10);
      return formData;
   } catch (error) {
      console.log(error);
   }
};

// get form data by form id
const getFormById = async (id: string) => {
   try {
      const formData = await Form.findOne({ _formId: id });
      return formData;
   } catch (error) {
      console.log(error);
      return null;
   }
};

// remove form data by id
const removeFormById = async (id: string) => {
   try {
      const formData = await Form.findByIdAndDelete(id);
      return formData;
   } catch (error) {
      console.log(error);
      return null;
   }
};

// remove all form data
const removeAllForm = async () => {
   try {
      const formData = await Form.deleteMany();
      return formData;
   } catch (error) {
      console.log(error);
      return null;
   }
};

// // update form data by id
// const updateFormById = async (id: string, form: any) => {
//    try {
//       const formData = await Form.findByIdAndUpdate(id, form);
//       return formData;
//    } catch (error) {
//       console.log(error);
//    }
// };



export default { Form, ObjectId, saveForm, getForm, getFormById, removeFormById, removeAllForm };