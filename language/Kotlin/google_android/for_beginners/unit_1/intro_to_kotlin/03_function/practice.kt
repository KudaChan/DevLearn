fun main() {
    println(birthdayGreeting())
    println("\n")
    println(birthdayGreetingName("Rover"))
    println("\n")
    println(birthdayGreetingNameAge("Rover", 5))
    println("\n")
    println(birthdayGreetingNameAge(name = "Rover", age = 6))
    println("\n")
    birthdayGreetingNameAgeDefault(name = "Rover")
}

fun birthdayGreeting(): String {
    val nameGreeting = "Happy Birthday, Rover!"
    val ageGreeting = "You are now 5 year old!"
    return "$nameGreeting\n$ageGreeting"
}

fun birthdayGreetingName(name: String): String {
    val nameGreeting = "Happy Birthday, $name!"
    val ageGreeting = "You are now 5 year old!"
    return "$nameGreeting\n$ageGreeting"
}

fun birthdayGreetingNameAge(name: String, age:Int): String {
    val nameGreeting = "Happy Birthday, $name!"
    val ageGreeting = "You are now $age year old!"
    return "$nameGreeting\n$ageGreeting"
}

fun birthdayGreetingNameAgeDefault(name: String = "Rex", age: Int = 5) {
    val nameGreeting = "Happy Birthday, $name!"
    val ageGreeting = "You are now $age year old!"
    println("$nameGreeting\n$ageGreeting")
}