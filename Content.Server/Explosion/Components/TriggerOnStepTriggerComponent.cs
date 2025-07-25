// SPDX-FileCopyrightText: 2022 Kara <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Server.Explosion.Components;

/// <summary>
/// This is used for entities that want the more generic 'trigger' behavior after a step trigger occurs.
/// Not done by default, since it's not useful for everything and might cause weird behavior. But it is useful for a lot of stuff like mousetraps.
/// </summary>
[RegisterComponent]
public sealed partial class TriggerOnStepTriggerComponent : Component
{
}
