var textInput = '<input class="mx-auto my-2 w-100 d-block" type="text">'

function addNewTextBox(thing) {
    if (thing == "ingredient") {
        $(textInput).appendTo('#ingredients');
    } else if (thing == "instruction") {
        $(textInput).appendTo('#instructions');
    } else {
        print("A valid input was not received for the addNewTextBox function.")
    }
}

function removeFromList(thing) {
    if (thing == "ingredient") {
        //var ingredients = $("#ingredients");
        //$(ingredients.lastChild).remove();
        $('#ingredients input').last().remove();
    } else if (thing == "instruction") {
        //var instructions = $("#instructions");
        //$(instructions.lastChild).remove();
        $('#instructions input').last().remove();
    } else {
        print("A valid input was not received for the removeFromList function");
    }
}