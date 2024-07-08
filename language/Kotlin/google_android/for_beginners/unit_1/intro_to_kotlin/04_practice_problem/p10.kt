fun main() {
    var city = "Ankara"
    var tempLow = "27"
    var tempHigh = "31"
    var rain = "82%"
    message(city, tempLow, tempHigh, rain)

    city = "Istanbul"
    tempLow = "25"
    tempHigh = "29"
    rain = "75%"
    message(city, tempLow, tempHigh, rain)
}

fun message(city: String, tempLow: String, tempHigh: String, rain: String) {
    println("City: $city")
    println("Low temperature: $tempLow, High temperature: $tempHigh")
    println("Rain: $rain")
    println()
}