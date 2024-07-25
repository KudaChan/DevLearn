document.addEventListener("DOMContentLoaded", () => {
   const hamburger = document.getElementById("hamburger");
   const sideNav = document.getElementById("side-nav");

   if (hamburger && sideNav) {
      hamburger.addEventListener("click", () => {
         sideNav.classList.toggle("active");
      });
   }



   const form = document.getElementById('form')

   form?.addEventListener('submit', async (event) => {
      event.preventDefault();

      if (!(form instanceof HTMLFormElement)) {
         console.error('Form element is not a valid HTMLFormElement');
         return;
      }

      const formData = new FormData(form);
      const formObject = Object.fromEntries(formData.entries());

      try {
         const response = await fetch('http://localhost:5000/form', {
            method: 'POST',
            headers: {
               'Content-Type': 'application/json',
            },
            body: JSON.stringify(formObject),
         });

         const data = await response.json();
         if (response.ok) {
            window.location.href = `thankYou.html?formId=${data.formId}`;
         } else {
            console.error('Error:', data.message);
         }
      } catch (error) {
         console.error('Error:', error);
      }
   });


});