using MagicScript;
using System.Text.Json;

Spell fireball = new Spell
{
    target = new Target { maxDistance = 150, type = TargetType.Direction },
    effect = Effect.Discharge,
    content = new Spell
    {
        target = new Target { maxDistance = 20, type = TargetType.Radius },
        effect = Effect.Discharge,
        condition = new Spell { element = Element.Force },
        content = new Spell { element = Element.Heat }
    }
};

Spell wallOfForce = new Spell
{
    target = new Target { maxDistance = 150, type = TargetType.Direction },
    effect = Effect.Discharge,
    content = new Spell
    {
        target = new Target { minDistance = 16, maxDistance = 20, type = TargetType.Radius },
        effect = Effect.Discharge,
        condition = new Spell { element = Element.Force },
        duration = 10,
        content = new Spell { element = Element.Force }
    }
};

Spell light = new Spell
{
    target = new Target { type = TargetType.Touch },
    effect = Effect.Discharge,
    content = new Spell
    {
        target = new Target { maxDistance = 40, type = TargetType.Radius },
        effect = Effect.Discharge,
        duration = 60,
        content = new Spell { element = Element.Light }
    }
};

Spell arcaneEye = new Spell
{
    effect = Effect.Absorb,
    content = new Spell
    {
        target = new Target { maxDistance = 30, type = TargetType.Radius },
        condition = new Spell { element = Element.Light },
        duration = 60
    },
    element = Element.Mind
};

Spell HoldPerson = new Spell
{
    target = new Target { maxDistance = 60, type = TargetType.Direction },
    effect = Effect.Discharge,
    content = new Spell
    {
        target = new Target { maxDistance = 1, type = TargetType.Radius },
        effect = Effect.Absorb,
        condition = new Spell { element = Element.Mind },
        duration = 1,
        element = Element.Mind
    }
};

Spell ShapeWater = new Spell
{
    target = new Target { maxDistance = 5, type = TargetType.Radius },
    effect = Effect.Shape,
    content = new Spell { element = Element.Water },
    duration = 60,
};

Spell Alarm = new Spell
{
    target = new Target { type = TargetType.Touch },
    effect = Effect.Discharge,
    content = new Spell
    {
        effect = Effect.Absorb,
        content = new Spell
        {
            target = new Target { maxDistance = 30, type = TargetType.Radius },
            condition = new Spell { element = Element.Mind }
        }
    }
};

Console.WriteLine(JsonSerializer.Serialize(fireball, options: new() { WriteIndented = true }));
