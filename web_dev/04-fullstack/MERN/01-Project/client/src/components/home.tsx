function Home() {
   return (
      <div>
         <h1>Home Page</h1>
         <div className="button">
            <button className="login" id="login" onClick={() => {
               window.location.href = "/login";
            }}>Login</button>
            <button className="signup" id="signup" onClick={() => {
               window.location.href = "/signup";
            }}>Signup</button>
         </div>
      </div>
   );
}

export default Home;