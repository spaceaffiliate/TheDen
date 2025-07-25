// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;

/// <summary>
/// When activated, will teleport the artifact
/// to a random position within a certain radius
/// </summary>
[RegisterComponent]
public sealed partial class RandomTeleportArtifactComponent : Component
{
    /// <summary>
    /// The max distance that the artifact will teleport.
    /// </summary>
    [DataField("maxRange")]
    public float MaxRange = 15f;

    /// <summary>
    /// The min distance that the artifact will teleport.
    /// </summary>
    [DataField("minRange")]
    public float MinRange = 6f;
}
