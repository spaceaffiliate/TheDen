// SPDX-FileCopyrightText: 2025 Eris <eris@erisws.com>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later AND MIT

using Robust.Shared.GameStates;

namespace Content.Shared._Lavaland.Weapons.Block;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class BlockChargeComponent : Component
{
    /// <summary>
    /// Time between gaining block charges
    /// </summary>
    [DataField, AutoNetworkedField]
    public float RechargeTime = 10f;

    /// <summary>
    /// How much time is reduced from recharge when hitting a marked target
    /// </summary>
    [DataField, AutoNetworkedField]
    public float MarkerReductionTime = 5f;

    /// <summary>
    /// When the next charge will be ready
    /// </summary>
    [DataField, AutoNetworkedField]
    public TimeSpan NextCharge;

    /// <summary>
    /// Whether we currently have a charge ready
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool HasCharge;
}
