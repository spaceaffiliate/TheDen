// SPDX-FileCopyrightText: 2022 Rane <60792108+Elijahrane@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 rolfero <45628623+rolfero@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 wrexbe <81056464+wrexbe@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Leon Friedrich <60421075+ElectroJr@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Visne <39844191+Visne@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Ygg01 <y.laughing.man.y@gmail.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 ShatteredSwords <135023515+ShatteredSwords@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 VMSolidus <evilexecutive@gmail.com>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later AND MIT

using Content.Shared.Alert;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Abilities.Mime
{
    /// <summary>
    /// Lets its owner entity use mime powers, like placing invisible walls.
    /// </summary>
    [RegisterComponent]
    public sealed partial class MimePowersComponent : Component
    {
        /// <summary>
        /// Whether this component is active or not.
        /// </summarY>
        [DataField("enabled")]
        public bool Enabled = true;

        /// <summary>
        /// The wall prototype to use.
        /// </summary>
        [DataField("wallPrototype", customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
        public string WallPrototype = "WallInvisible";

        [DataField("invisibleWallAction", customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
        public string? InvisibleWallAction = "ActionMimeInvisibleWall";

        [DataField("invisibleWallActionEntity")] public EntityUid? InvisibleWallActionEntity;

        // The vow zone lies below
        public bool VowBroken = false;

        /// <summary>
        /// Whether this mime is ready to take the vow again.
        /// Note that if they already have the vow, this is also false.
        /// </summary>
        public bool ReadyToRepent = false;

        /// <summary>
        /// Time when the mime can repent their vow
        /// </summary>
        [DataField("vowRepentTime", customTypeSerializer: typeof(TimeOffsetSerializer))]
        public TimeSpan VowRepentTime = TimeSpan.Zero;

        /// <summary>
        /// How long it takes the mime to get their powers back
        /// </summary>
        [DataField("vowCooldown")]
        public TimeSpan VowCooldown = TimeSpan.FromMinutes(5);

        [DataField]
        public ProtoId<AlertPrototype> VowAlert = "VowOfSilence";

        [DataField]
        public ProtoId<AlertPrototype> VowBrokenAlert = "VowBroken";

    }
}
