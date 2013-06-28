/// <reference path="../Scripts/jquery-1.7.1.min.js" />
/// <reference path="../Scripts/knockout-2.1.0.js" />

$(document).ready(function () {
    ko.applyBindings(new spellViewModel(), document.getElementById('createNode'));
});

// Name:        Spell
// Description: View Model which is responsible for managing 
//              the content on the create spell page
var spellViewModel = function ( id,
                                name,
                                description,
                                spellResistance,
                                target,
                                castingTime,
                                range,
                                savingThrow,
                                school,
                                type,
                                duration,
                                levelToAdd,
                                classToAdd) {

    var self = this;

    // All the attributes associated with a spell
    self.Id = id;
    self.Name = name;
    self.Description = description;
    self.SpellResistance = spellResistance;
    self.Target = target;
    self.CastingTime = castingTime;
    self.Range = range;
    self.SavingThrow = savingThrow;
    self.School = school;
    self.Type = type;
    self.Duration = duration;

    self.LevelToAdd = levelToAdd;
    self.ClassToAdd = classToAdd;

    // Load up the Child Models
    this.Component = new SpellComponentViewModel();

    // Data Attribute Resposible for storing all the spell levels
    self.SpellLevels = ko.observableArray();

    // Name:        addSpellLevel
    // Description  Responsible for adding a Spell Level to the list on the Page 
    //              based on the data provided by the user
    self.addSpellLevel = function () {
        self.SpellLevels.push({ spellClass: self.ClassToAdd, level: self.LevelToAdd });
    };

    // Name:        removeSpellLevel
    // Description: Responsible for removing the the spellLevel from the list 
    //              just in case the sure makes a mistake
    self.removeSpellLevel = function () {
        self.SpellLevels.remove(this);
    };

    // Name:        addSpell
    // Description: Takes the data contained in the View and sends it back 
    //              to the server to be inserted into the database
    self.addSpell = function () {
        $.ajax({
            url: "/spell/create/",
            type: 'post',
            data: ko.toJSON(this),
            contentType: 'application/json',
            success: function (result) {
                alert("Spell Has Been Successfully Created!");
            }
        });
    }
}

// Name:        SpellComponentViewModel
// Description: Handles the attributes associated with the component 
//              aspect of the spell
var SpellComponentViewModel = function (verbal, somatic, material, focus) {

    self.Verbal = verbal;
    self.Somatic = somatic;
    self.Material = material;
    self.Focus = focus;

}


