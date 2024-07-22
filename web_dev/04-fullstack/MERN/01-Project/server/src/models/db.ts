import mongoose from "mongoose";

const Schema = mongoose.Schema;
const ObjectId = Schema.ObjectId;

const userSchema = new Schema({
   id: ObjectId,
   name: String,
   email: String,
   password: String,
});

const User = mongoose.model("User", userSchema);
const saveUser = async (user: string, email: string, password: string) => {
   const newUser = new User({
      name: user,
      email: email,
      password: password,
   });
   try {
      await newUser.save();
      return newUser;
   } catch (err) {
      return console.log(err);
   }
}

const getUsers = async () => {
   try {
      const users = await User.find();
      return users;
   } catch (err) {
      return console.log(err);
   }
}

const getUserById = async (id: string) => {
   try {
      const user = await User.findById(id);
      return user;
   } catch (err) {
      return console.log(err);
   }
}

const getUserByMail = async (email: string, password: string) => {
   try {
      const user = await User.findOne({ email, password });
      if (user === null) {
         return { message: "User not found. PLEASE SIGN IN" };
      } else if (user.password !== password) {
         return { message: "Password is incorrect" };
      } else {
         return user;
      }
   } catch (err) {
      return console.log(err);
   }
}

const updateUser = async (id: string, user: typeof User) => {
   try {
      const updatedUser = await User.findByIdAndUpdate(id, user);
      return updatedUser;
   } catch (err) {
      return console.log(err);
   }
}

const deleteUser = async (id: string) => {
   try {
      const deletedUser = await User.findByIdAndDelete(id);
      return deletedUser;
   } catch (err) {
      return console.log(err);
   }
}

const deleteAllUsers = async () => {
   try {
      const deletedUsers = await User.deleteMany();
      return deletedUsers;
   } catch (err) {
      return console.log(err);
   }
}

export default { User, saveUser, getUsers, getUserById, getUserByMail, updateUser, deleteUser, deleteAllUsers };