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

function submitRecipeForm(ParameterTitle, RecipeId) {
    //TODO: make a list of strings out of the ingredients

    //TODO: make a list of strings out of the instructions

    //TODO: make an object of all the form data

    //TODO: if the ParameterTitle is 'edit' then bundle the response object with the RecipeId and send AJAX to 'Edit' ActionMethod

    //TODO: if the Parametertitle is 'create' then bundle the form data as a response object and send AJAX to 'New' ActionMethod

    //TODO: check if response is success, if yes redirect to list view, else display error message
}