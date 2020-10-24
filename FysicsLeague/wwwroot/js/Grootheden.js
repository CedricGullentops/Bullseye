function generateNumbers() {
    var minNumber = 0; // The minimum number you want
    var maxNumber = 100; // The maximum number you want
    var randomnumber = Math.floor(Math.random() * (maxNumber + 1) + minNumber); // Generates random number
    //$('#inputvalue').html(randomnumber); // Sets content of <div> to number
    $('#inputprefix').html('µ'); // Sets content of <div> to number
    $('#inputunit').html('C'); // Sets content of <div> to number
    $('#outputprefix').html('m'); // Sets content of <div> to number
    $('#outputunit').html('C'); // Sets content of <div> to number


    var minNumber = 0; // The minimum number you want
    var maxNumber = 1;
    var randomnumber = Math.floor(Math.random() * (maxNumber + 1) + minNumber);

    let prefixes = prefix()
    $('#inputvalue').html(prefixes[randomnumber]);

    return false; // Returns false just to tidy everything up
}
