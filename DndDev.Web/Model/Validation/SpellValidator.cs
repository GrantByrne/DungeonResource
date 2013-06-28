using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using DndDev.Domain.Spell;

namespace DndDev.Web.Model.Validation
{
    /// <summary>
    /// Validate the input for a Spell Object
    /// </summary>
    public class SpellValidator : AbstractValidator<Spell>
    {
        public SpellValidator()
        {
            // Name
            RuleFor(Spell => Spell.Name).NotEmpty().WithMessage("Please enter a spell name.");

            //// Target
            //RuleFor(Spell => Spell.Targets).NotEmpty().WithMessage("Please specify a target.");

            //// Casting Time
            //RuleFor(Spell => Spell.CastingTime).NotEmpty().WithMessage("Please specify a casting time.");

            //// Duration
            //RuleFor(Spell => Spell.Duration).NotEmpty().WithMessage("Please specify a spell duration.");

            //// Description
            //RuleFor(Spell => Spell.Description).NotEmpty().WithMessage("Please specify a spell description.");

            // Class Levels
            RuleFor(Spell => Spell.SpellLevels).NotNull().WithMessage("Please specify at least one class level.");
            RuleFor(Spell => Spell.SpellLevels).NotEmpty().WithMessage("Please specify at least one class level.");

            //RuleFor(Spell => Spell.SpellLevels).Must((Spell, d) =>
            //    {
            //        for (int x = 0; x < d.Count; x++)
            //        {
            //            if (string.IsNullOrEmpty(d[0].SpellClass))
            //            {
            //                return false;
            //            }    
            //        }
                    
            //        return true;
            //    }
                
            //    ).WithMessage("None of the class names can be empty.");

        }
    }
}