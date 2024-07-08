fun main() {
    var timeSpentToday = 300
    var timeSpentYesterday = 250
    println(compare(timeSpentToday, timeSpentYesterday))

    timeSpentToday = 300
    timeSpentYesterday = 300
    println(compare(timeSpentToday, timeSpentYesterday))

    timeSpentToday = 250
    timeSpentYesterday = 300
    println(compare(timeSpentToday, timeSpentYesterday))
}

fun compare(firstNo: Int, secondNo: Int): Boolean {
    return firstNo > secondNo
}