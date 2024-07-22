import { useState } from "react";

function Signup() {
   const [username, setUsername] = useState("");
   const [email, setEmail] = useState("");
   const [password, setPassword] = useState("");

   function handleSignup(e: React.FormEvent<HTMLFormElement>) {
      e.preventDefault();
      fetch("http://localhost:5000/signup", {
         method: "POST",
         headers: {
            "Content-Type": "application/json",
         },
         body: JSON.stringify({ username, email, password }),
      })
      .then((res) => res.json())
      .then((data) => {
         console.log(data);
         })
         .catch((err) => console.log(err.message));
   }

   return (
      <div>
         <form onSubmit={handleSignup}>
            <h1>Signup Page</h1>
            <label htmlFor="username">Username</label>
            <input type="text" id="username" name="username" value={username} onChange={(e) => setUsername(e.target.value)} />
            <label htmlFor="email">Email</label>
            <input type="email" id="email" name="email" value={email} onChange={(e) => setEmail(e.target.value)} />
            <label htmlFor="password">Password</label>
            <input type="password" id="password" name="password" value={password} onChange={(e) => setPassword(e.target.value)} />
            <button>Signup</button>
         </form>
      </div>
   );
}

export default Signup;