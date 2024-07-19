// import ListGroup from "./components/ListGroup";
// import Alert from "./components/Alert";
import { useState } from "react";
import Alert from "./components/Alert";
import Button from "./components/Button";

// function App() {
//   const items = [
//     "An item",
//     "A second item",
//     "A third item",
//     "A fourth item",
//     "And a fifth one",
//   ];

//   const handleSelectItem = (item: string) => {
//     console.log(item);
//   }

//   return (
//     <div>
//       <ListGroup items={items} heading="List Group" onSelectItem={handleSelectItem} />
//     </div>
//   );
// }

// function App() {
//   return (
//     <div>
//       <Alert>
//         <h1>Hello World</h1>
//       </Alert>
//     </div>
//   )
// }

function App() {
  const [showAlert, setShowAlert] = useState(false);
  return (
    <div>
      {showAlert && <Alert onClose={() => setShowAlert(false)
        
      }>I am Clicked</Alert>}
      <Button onClick={() => setShowAlert(true)} color="secondary">
        Click me
      </Button>
    </div>
  )
}

export default App;
