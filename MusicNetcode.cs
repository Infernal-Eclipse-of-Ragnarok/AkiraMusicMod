using System;
using System.IO;
using Terraria.ModLoader;

namespace AkiraIEoRMusic
{
    internal class MusicNetcode
    {
        public enum MusicMessageType : byte
        {
            MusicEventSyncRequest,
            MusicEventSyncResponse
        }

        public static void HandlePacket(Mod mod, BinaryReader reader, int whoAmI)
        {
            try
            {
                MusicMessageType msgType = (MusicMessageType)reader.ReadByte();
                switch (msgType)
                {
                    case MusicMessageType.MusicEventSyncRequest:
                        {
                            MusicEventSystem.FulfillSyncRequest(whoAmI);
                            break;
                        }

                    case MusicMessageType.MusicEventSyncResponse:
                        {
                            MusicEventSystem.ReceiveSyncResponse(reader);
                            break;
                        }

                    default:
                        {
                            AkiraIEoRMusic.Instance.Logger.Error($"Failed to parse VCMM packet: No VCMM packet exists with ID {msgType}.");
                            throw new Exception("Failed to parse VCMM packet: Invalid VCMM packet ID.");
                        }
                }
            }
            catch (Exception e)
            {
                if (e is EndOfStreamException eose)
                {
                    AkiraIEoRMusic.Instance.Logger.Error("Failed to parse VCMM packet: Packet was too short, missing data, or otherwise corrupt.", eose);
                }
                else if (e is ObjectDisposedException ode)
                {
                    AkiraIEoRMusic.Instance.Logger.Error("Failed to parse VCMM packet: Packet reader disposed or destroyed.", ode);
                }
                else if (e is IOException ioe)
                {
                    AkiraIEoRMusic.Instance.Logger.Error("Failed to parse VCMM packet: An unknown I/O error occurred.", ioe);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
