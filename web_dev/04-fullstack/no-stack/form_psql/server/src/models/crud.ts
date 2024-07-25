import pg from "pg";
import { v4 as uuidv4 } from "uuid";

const db = new pg.Pool({
   user: "kumar",
   password: "chan05dan",
   host: "localhost",
   port: 5432,
   database: "form",
});

// db connection




// create
const create = async (formData: any) => {
   const formId = uuidv4();
   try {
      const personalInfoQuery = 'INSERT INTO personal_info (form_id, f_name, m_name, l_name, mobile, mail, dob, gender) VALUES ($1, $2, $3, $4, $5, $6, $7, $8)'
      const personalInfoValues = [formId, formData.firstName, formData.middleName, formData.lastName, formData.phone, formData.email, formData.dob, formData.gender]
      let queryStatus
      try {
         queryStatus = await db.query(personalInfoQuery, personalInfoValues)
      } catch (error) {
         console.log(error);
      }

      if (queryStatus) {
         const fatherInfoQuery = 'INSERT INTO father_info (form_id, f_name, m_name, l_name, mobile, mail, occupation) VALUES ($1, $2, $3, $4, $5, $6, $7)'
         const fatherInfoValues = [formId, formData.fatherFirstName, formData.fatherMiddleName, formData.fatherLastName, formData.fatherPhone, formData.fatherEmail, formData.fatherOccupation]
         try {
            await db.query(fatherInfoQuery, fatherInfoValues)
         } catch (error) {
            console.log(error);
         }

         const motherInfoQuery = 'INSERT INTO mother_info (form_id, f_name, m_name, l_name, mobile, mail, occupation) VALUES ($1, $2, $3, $4, $5, $6, $7)'
         const motherInfoValues = [formId, formData.motherFirstName, formData.motherMiddleName, formData.motherLastName, formData.motherPhone, formData.motherEmail, formData.motherOccupation]
         try {
            await db.query(motherInfoQuery, motherInfoValues)
         } catch (error) {
            console.log(error);
         }

         const addressInfoQuery = 'INSERT INTO address (form_id, house_no, street, city, state, zip_code, country) VALUES ($1, $2, $3, $4, $5, $6, $7)'
         const addressInfoValues = [formId, formData.houseNo, formData.street, formData.city, formData.state, formData.zipCode, formData.country]
         try {
            await db.query(addressInfoQuery, addressInfoValues)
         } catch (error) {
            console.log(error);
         }

         const additionalInfoQuery = 'INSERT INTO additional_info (form_id, about, declaration, consent) VALUES ($1, $2, $3, $4)'
         const additionalInfoValues = [formId, formData.about, formData.declaration, formData.consent]
         try {
            await db.query(additionalInfoQuery, additionalInfoValues)
         } catch (error) {
            console.log(error);
         }
      } else {
         console.log("Form not created");
      }

      return { formId }
   } catch (error) {
      console.log(error);
   }
}

// read by formId
const readByFormId = async (formId: string) => {
   const personalInfoQuery = 'SELECT * FROM personal_info WHERE form_id = $1'
   const personalInfoValues = [formId]
   const personalInfo = await db.query(personalInfoQuery, personalInfoValues)
   return personalInfo.rows[0]
}

// read all entries
const readAll = async () => {
   try {
      const personalInfo = await db.query('SELECT * FROM personal_info');
      const entriesInfo = {
         formId: personalInfo.rows.map((row: any) => row.form_id),
         firstName: personalInfo.rows.map((row: any) => row.f_name),
         middleName: personalInfo.rows.map((row: any) => row.m_name),
         lastName: personalInfo.rows.map((row: any) => row.l_name),
         mobile: personalInfo.rows.map((row: any) => row.mobile),
         mail: personalInfo.rows.map((row: any) => row.mail),
      }
      return { entriesInfo, totalForms: personalInfo.rows.length }
   } catch (error) {
      console.log(error);
   }
}

// update
// todo: update by formId

// delete
const deleteByFormId = async (formId: string) => {
   const personalInfoQuery = 'DELETE FROM personal_info WHERE form_id = $1'
   const personalInfoValues = [formId]
   try {
      await db.query(personalInfoQuery, personalInfoValues)
      return { formId }
   } catch (error) {
      console.log(error);
   }
}



export default { create, readByFormId, readAll, deleteByFormId };