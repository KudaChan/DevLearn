import { useState } from "react";

function Login() {
   const [email, setEmail] = useState("");
   const [password, setPassword] = useState("");

   function handlelogin(e: React.FormEvent<HTMLFormElement>) {
      e.preventDefault();
      fetch("http://localhost:5000/login", {
         method: "POST",
         headers: {
            "Content-Type": "application/json",
         },
         body: JSON.stringify({ email, password }),
      });
   }

   return (
      <div>
         <form onSubmit={handlelogin}>
            <h1>Login Page</h1>
            <label htmlFor="email">Email</label>
            <input type="email" id="email" name="email" value={email} onChange={(e) => setEmail(e.target.value)} />
            <label htmlFor="password">Password</label>
            <input type="password" id="password" name="password" value={password} onChange={(e) => setPassword(e.target.value)} />
            <button>Login</button>
         </form>
      </div>
   );
}

export default Login;