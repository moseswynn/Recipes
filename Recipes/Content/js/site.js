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

function childrenValuesToArray(element) {
    //returns the values of the children of an element as an array
    var elementChildren = [].slice.call(element.children);
    var values = []
    elementChildren.forEach(function (element) { values.push(element.value) });
    return values
}

function submitRecipeForm(ParameterTitle, RecipeId) { 
    /*This exists because using MVC forms would not work due
     * to the number of inputs not being constant as the number
     * of ingredients and instruction steps vary.*/


    //package form data into an object:
    //1) capture name and description
    var name = $('#nameTextBox')[0].value;
    var description = $('#descriptionTextArea')[0].value
    //makes an array of objects from the ingredients and instructions
    var ingredientStrings = childrenValuesToArray($('#ingredients')[0]);
    var instructionStrings = childrenValuesToArray($('#instructions')[0]);
    var ingredients = [];
    for (i = 0; i < ingredientStrings.length; i++) {
        ingredients.push({ 'ingredientText': ingredientStrings[i] });
    }
    var instructions = [];
    for (i = 0; i < instructionStrings.length; i++) {
        instructions.push({
            'instructionIndex': i,
            'instructionText': instructionStrings[i]
        });
    }
    //package all form data into payload
    var payLoad = {
        'Name': name,
        'Description': description,
        'Instructions': instructions,
        'Ingredients': ingredients
    };
    //add RecipeId to the payload if the ParameterTitle is edit
    if (ParameterTitle == 'edit') {
        payLoad['RecipeId'] = RecipeId
    }
    //TODO: POST data and wait for response, if success redirect to home, else post error
    fetch('~/Recipe/Save', {
        method: 'POST',
        body: JSON.stringify(payLoad),
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .catch(error => console.error('error:', error))
        .then(response => console.log('success:', response));
    //TODO: check if response is success, if yes redirect to list view, else display error message
}