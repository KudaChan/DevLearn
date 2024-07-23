
document.addEventListener('DOMContentLoaded', async () => {
   const urlParams = new URLSearchParams(window.location.search);
   const formId = urlParams.get('formId');

   if (formId) {
      try {
         const response = await fetch(`http://localhost:5000/form/data/${formId}`);
         const data = await response.json();
         if (data) {
            const formElement = document.getElementById('formId');
            if (formElement) {
               formElement.textContent = data._formId;
            } else {
               console.error('Element with id "formId" not found.');
            }
         } else {
            console.error('Form data not found');
         }
      } catch (error) {
         console.error('Error fetching form data:', error);
      }
   }
});