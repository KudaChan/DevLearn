// hamburger menu
document.addEventListener('DOMContentLoaded', function () {
    const hamburger = document.getElementById('hamburger');
    const sidebar = document.querySelector('.sidebar-container');

    hamburger.addEventListener('click', function () {
        sidebar.classList.toggle('show');
    });
});

// values validation
const form = document.getElementById('form');

form.addEventListener('input', (e) => {
    e.preventDefault();
    if (validateForm() || validateFatherInfo() || validateMotherInfo() || validateAddressInfo()) {
        form.submit();
    }
});

form.addEventListener('submit', (e) => {
    e.preventDefault();
    if (validatePersonalInfo() || validateFatherInfo() || validateMotherInfo() || validateAddressInfo()) {
        form.submit();
    }
});

// Personal Information declaration
const firstName = document.getElementById('first-name');
const middleName = document.getElementById('middle-name');
const lastName = document.getElementById('last-name');
const email = document.getElementById('email');
const gender = document.getElementById('gender');
const callCode = document.getElementById('call-code');
const phoneNumber = document.getElementById('phone-number');
const dateOfBirth = document.getElementById('date-of-birth');

const firstNameError = document.getElementById('first-name-error');
const middleNameError = document.getElementById('middle-name-error');
const lastNameError = document.getElementById('last-name-error');
const emailError = document.getElementById('email-error');
const genderError = document.getElementById('gender-error');
const callCodeError = document.getElementById('call-code-error');
const phoneNumberError = document.getElementById('phone-number-error');
const dateOfBirthError = document.getElementById('date-of-birth-error');

// Personal Information validation
const validatePersonalInfo = () => {
    let isValid = true;

    // First Name Validation
    if (firstName.value === '') {
        firstNameError.style.display = 'block';
        firstNameError.innerHTML = 'First name is required';
        isValid = false;
    } else if (firstName.value.match(/^[a-zA-Z]+( [a-zA-Z]+){1,}$/)) {
        firstNameError.innerHTML = 'First name should not contain spaces';
        firstNameError.style.display = 'block';
        isValid = false;
    } else {
        firstNameError.style.display = 'none';
    }

    // Middle Name Validation
    if (middleName.value.match(/^[a-zA-Z]+( [a-zA-Z]+){1,}$/)) {
        middleNameError.innerHTML = 'Middle name should not contain spaces';
        middleNameError.style.display = 'block';
        isValid = false;
    } else {
        middleNameError.style.display = 'none';
    }

    // Last Name Validation
    if (lastName.value === '') {
        lastNameError.innerHTML = 'Last name is required';
        lastNameError.style.display = 'block';
        isValid = false;
    } else if (lastName.value.match(/^[a-zA-Z]+( [a-zA-Z]+){1,}$/)) {
        lastNameError.innerHTML = 'Last name should not contain spaces';
        lastNameError.style.display = 'block';
        isValid = false;
    } else {
        lastNameError.style.display = 'none';
    }

    // Email Validation
    if (email.value === '') {
        emailError.innerHTML = 'Email is required';
        emailError.style.display = 'block';
        isValid = false;
    } else if (!email.value.match(/^([a-zA-Z0-9_\-\.])+\@([a-zA-Z0-9_\-\.])+\.[a-zA-Z]{2,4}$/)) {
        emailError.innerHTML = 'Invalid email address';
        emailError.style.display = 'block';
        isValid = false;
    } else {
        emailError.style.display = 'none';
    }

    // Gender Validation
    if (gender.value === '') {
        genderError.innerHTML = 'Select gender';
        genderError.style.display = 'block';
        isValid = false;
    } else {
        genderError.style.display = 'none';
    }

    // Call code Validation
    if (callCode.value === '') {
        callCodeError.innerHTML = 'Select correct call code';
        callCodeError.style.display = 'block';
        isValid = false;
    } else {
        callCodeError.style.display = 'none';
    }

    // Phone Number Validation
    if (phoneNumber.value === '') {
        phoneNumberError.innerHTML = 'Phone number is required';
        phoneNumberError.style.display = 'block';
        isValid = false;
    } else if (!phoneNumber.value.match(/^[0-9]{10}$/)) {
        phoneNumberError.innerHTML = 'Invalid phone number';
        phoneNumberError.style.display = 'block';
        isValid = false;
    } else {
        phoneNumberError.style.display = 'none';
    }

    // Date of Birth Validation
    if (dateOfBirth.value === '') {
        dateOfBirthError.innerHTML = 'Date of birth is required';
        dateOfBirthError.style.display = 'block';
        isValid = false;
    } else {
        dateOfBirthError.style.display = 'none';
    }

    return isValid;
}

// Father's Information declaration
const fatherFirstName = document.getElementById('father-first-name');
const fatherMiddleName = document.getElementById('father-middle-name');
const fatherLastName = document.getElementById('father-last-name');
const fatherEmail = document.getElementById('father-email');
const fatherPhoneNumber = document.getElementById('father-phone-number');
const fatherOccupation = document.getElementById('father-occupation');

const fatherFirstNameError = document.getElementById('father-first-name-error');
const fatherMiddleNameError = document.getElementById('father-middle-name-error');
const fatherLastNameError = document.getElementById('father-last-name-error');
const fatherEmailError = document.getElementById('father-email-error');
const fatherPhoneNumberError = document.getElementById('father-phone-number-error');
const fatherOccupationError = document.getElementById('father-occupation-error');

// Father's Information validation
const validateFatherInfo = () => {
    let isValid = true;

    // father first name validation
    if (fatherFirstName.value === '') {
        fatherFirstNameError.innerHTML = 'Father\'s first name is required';
        fatherFirstNameError.style.display = 'block';
        isValid = false;
    } else if (fatherFirstName.value.match(/^[a-zA-Z]+( [a-zA-Z]+){1,}$/)) {
        fatherFirstNameError.innerHTML = 'Father\'s first name should not contain spaces';
        fatherFirstNameError.style.display = 'block';
        isValid = false;
    } else {
        fatherFirstNameError.style.display = 'none';
    }

    // Father's Middle Name Validation
    if (fatherMiddleName.value.match(/^[a-zA-Z]+( [a-zA-Z]+){1,}$/)) {
        fatherMiddleNameError.innerHTML = 'Father\'s middle name should not contain spaces';
        fatherMiddleNameError.style.display = 'block';
        isValid = false;
    } else {
        fatherMiddleNameError.style.display = 'none';
    }

    // Father's Last Name Validation
    if (fatherLastName.value === '') {
        fatherLastNameError.innerHTML = 'Father\'s last name is required';
        fatherLastNameError.style.display = 'block';
        isValid = false;
    } else if (fatherLastName.value.match(/^[a-zA-Z]+( [a-zA-Z]+){1,}$/)) {
        fatherLastNameError.innerHTML = 'Father\'s last name should not contain spaces';
        fatherLastNameError.style.display = 'block';
        isValid = false;
    } else {
        fatherLastNameError.style.display = 'none';
    }

    // Father's Email Validation
    if (fatherEmail.value === '') {
        fatherEmailError.innerHTML = 'Father\'s email is required';
        fatherEmailError.style.display = 'block';
        isValid = false;
    } else if (!fatherEmail.value.match(/^([a-zA-Z0-9_\-\.])+\@([a-zA-Z0-9_\-\.])+\.[a-zA-Z]{2,4}$/)) {
        fatherEmailError.innerHTML = 'Invalid email address';
        fatherEmailError.style.display = 'block';
        isValid = false;
    } else {
        fatherEmailError.style.display = 'none';
    }

    // Father's Phone Number Validation
    if (fatherPhoneNumber.value === '') {
        fatherPhoneNumberError.innerHTML = 'Father\'s phone number is required';
        fatherPhoneNumberError.style.display = 'block';
        isValid = false;
    } else if (!fatherPhoneNumber.value.match(/^\+\d{12}$/)) {
        fatherPhoneNumberError.innerHTML = 'Invalid phone number';
        fatherPhoneNumberError.style.display = 'block';
        isValid = false;
    } else {
        fatherPhoneNumberError.style.display = 'none';
    }

    // Father's Occupation Validation
    if (fatherOccupation.value === '') {
        fatherOccupationError.innerHTML = 'Father\'s occupation is required';
        fatherOccupationError.style.display = 'block';
        isValid = false;
    } else {
        fatherOccupationError.style.display = 'none';
    }

    return isValid;
}

// Mother's Information declaration
const motherFirstName = document.getElementById('mother-first-name');
const motherMiddleName = document.getElementById('mother-middle-name');
const motherLastName = document.getElementById('mother-last-name');
const motherEmail = document.getElementById('mother-email');
const motherPhoneNumber = document.getElementById('mother-phone-number');
const motherOccupation = document.getElementById('mother-occupation');

const motherFirstNameError = document.getElementById('mother-first-name-error');
const motherMiddleNameError = document.getElementById('mother-middle-name-error');
const motherLastNameError = document.getElementById('mother-last-name-error');
const motherEmailError = document.getElementById('mother-email-error');
const motherPhoneNumberError = document.getElementById('mother-phone-number-error');
const motherOccupationError = document.getElementById('mother-occupation-error');

// Mother's Information validation
const validateMotherInfo = () => {
    let isValid = true;

    // Mother's First Name Validation
    if (motherFirstName.value === '') {
        motherFirstNameError.innerHTML = 'Mother\'s first name is required';
        motherFirstNameError.style.display = 'block';
        isValid = false;
    } else if (motherFirstName.value.match(/^[a-zA-Z]+( [a-zA-Z]+){1,}$/)) {
        motherFirstNameError.innerHTML = 'Mother\'s first name should not contain spaces';
        motherFirstNameError.style.display = 'block';
        isValid = false;
    } else {
        motherFirstNameError.style.display = 'none';
    }

    // Mother's Middle Name Validation
    if (motherMiddleName.value.match(/^[a-zA-Z]+( [a-zA-Z]+){1,}$/)) {
        motherMiddleNameError.innerHTML = 'Mother\'s middle name should not contain spaces';
        motherMiddleNameError.style.display = 'block';
        isValid = false;
    } else {
        motherMiddleNameError.style.display = 'none';
    }

    // Mother's Last Name Validation
    if (motherLastName.value === '') {
        motherLastNameError.innerHTML = 'Mother\'s last name is required';
        motherLastNameError.style.display = 'block';
        isValid = false;
    } else if (motherLastName.value.match(/^[a-zA-Z]+( [a-zA-Z]+){1,}$/)) {
        motherLastNameError.innerHTML = 'Mother\'s last name should not contain spaces';
        motherLastNameError.style.display = 'block';
        isValid = false;
    } else {
        motherLastNameError.style.display = 'none';
    }

    // Mother's Email Validation
    if (motherEmail.value === '') {
        motherEmailError.innerHTML = 'Mother\'s email is required';
        motherEmailError.style.display = 'block';
        isValid = false;
    } else if (!motherEmail.value.match(/^([a-zA-Z0-9_\-\.])+\@([a-zA-Z0-9_\-\.])+\.[a-zA-Z]{2,4}$/)) {
        motherEmailError.innerHTML = 'Invalid email address';
        motherEmailError.style.display = 'block';
        isValid = false;
    } else {
        motherEmailError.style.display = 'none';
    }

    // Mother's Phone Number Validation
    if (motherPhoneNumber.value === '') {
        motherPhoneNumberError.innerHTML = 'Mother\'s phone number is required';
        motherPhoneNumberError.style.display = 'block';
        isValid = false;
    } else if (!motherPhoneNumber.value.match(/^\+\d{12}$/)) {
        motherPhoneNumberError.innerHTML = 'Invalid phone number';
        motherPhoneNumberError.style.display = 'block';
        isValid = false;
    } else {
        motherPhoneNumberError.style.display = 'none';
    }

    // Mother's Occupation Validation
    if (motherOccupation.value === '') {
        motherOccupationError.innerHTML = 'Mother\'s occupation is required';
        motherOccupationError.style.display = 'block';
        isValid = false;
    } else {
        motherOccupationError.style.display = 'none';
    }

    return isValid;
}

// Address Information declaration
const houseNo = document.getElementById('house-no');
const street = document.getElementById('street');
const city = document.getElementById('city');
const state = document.getElementById('state');
const postalCode = document.getElementById('postal-code');
const country = document.getElementById('country');

const houseNoError = document.getElementById('house-no-error');
const streetError = document.getElementById('street-error');
const cityError = document.getElementById('city-error');
const stateError = document.getElementById('state-error');
const postalCodeError = document.getElementById('postal-code-error');
const countryError = document.getElementById('country-error');

// Address Information validation
const validateAddressInfo = () => {
    let isValid = true;

    // House Number Validation
    if (houseNo.value === '') {
        houseNoError.innerHTML = 'House number is required';
        houseNoError.style.display = 'block';
        isValid = false;
    } else {
        houseNoError.style.display = 'none';
    }

    // Street Validation
    if (street.value === '') {
        streetError.innerHTML = 'Street is required';
        streetError.style.display = 'block';
        isValid = false;
    } else {
        streetError.style.display = 'none';
    }

    // City Validation
    if (city.value === '') {
        cityError.innerHTML = 'City is required';
        cityError.style.display = 'block';
        isValid = false;
    } else {
        cityError.style.display = 'none';
    }

    // State Validation
    if (state.value === '') {
        stateError.innerHTML = 'State is required';
        stateError.style.display = 'block';
        isValid = false;
    } else {
        stateError.style.display = 'none';
    }

    // Postal Code Validation
    if (postalCode.value === '') {
        postalCodeError.innerHTML = 'Postal code is required';
        postalCodeError.style.display = 'block';
        isValid = false;
    } else {
        postalCodeError.style.display = 'none';
    }

    // Country Validation
    if (country.value === '') {
        countryError.innerHTML = 'Country is required';
        countryError.style.display = 'block';
        isValid = false;
    } else {
        countryError.style.display = 'none';
    }

    return isValid;
}