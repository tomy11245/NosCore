﻿using NosCore.Core.Serializing;

namespace NosCore.GameObject.Packets.ServerPackets
{
    [PacketHeader("mv")]
    public class MovePacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public byte VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualEntityId { get; set; }

        [PacketIndex(2)]
        public short MapX { get; set; }

        [PacketIndex(3)]
        public short MapY { get; set; }

        [PacketIndex(4)]
        public byte Speed { get; set; }

        #endregion
    }
}
