using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memory2;

namespace WaveClient.SDK
{
    public class LocalPlayer
    {
        public LocalPlayer(UInt64 addr) : base(addr)
        {
        }
        //SDK stuffs


        //Player offset shiz
        /*
        public void teleport(float x, float y, float z)
        {
            currentX1 = x;
            currentY1 = y;
            currentZ1 = z;
            X1 = x;
            X2 = x + 0.6f;
            Y1 = y;
            Y2 = y + 1.8f;
            Z1 = z;
            Z2 = z + 0.6f;
        } */

        public double velocityXZ
        {
            get
            {
                return Math.Sqrt(velX * velX + velZ * velZ);
            }
        }

        public double velocityXYZ
        {
            get
            {
                return Math.Sqrt(velX * velX + velY * velY + velZ * velZ);
            }
        }
        /*
        public Utils.Vec3f lookingVec
        {
            get
            {
                return Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw + 89.9f) * (float)Math.PI / 178F, Minecraft.clientInstance.localPlayer.pitch * (float)Math.PI / 178F);
            }
        }
        */
        public new ulong addr = 0x036972F0;
        public byte onGround
        {
            get
            {
                return memory2.main.readByte(addr + 0x178);
            }
            set
            {
                memory2.main.writeByte(addr + 0x178, value);
            }
        }
        public int onGround_type2
        {
            get
            {
                return memory2.main.readInt(addr + 0x17B);
            }
        }
        public byte isFlying
        {
            get
            {
                return memory2.main.readByte(addr + 0xAB8);
            }
            set
            {
                memory2.main.writeByte(addr + 0xAB8, value);
            }
        }
        public byte isInAir
        {
            get
            {
                return memory2.main.readByte(addr + 0x17C);
            }
            set
            {
                memory2.main.writeByte(addr + 0x17C, value);
            }
        }
        public int isInWater
        {
            get
            {
                return memory2.main.readInt(addr + 0x215);
            }
            set
            {
                memory2.main.writeInt(addr + 0x215, value);
            }
        }
        public int currentGamemode
        {
            get
            {
                return memory2.main.readInt(addr + 0x1E74);
            }
            set
            {
                memory2.main.writeInt(addr + 0x1E74, value);
            }
        }
        public int viewCreativeItems
        {
            get
            {
                return memory2.main.readInt(addr + 0xAD0);
            }
            set
            {
                memory2.main.writeInt(addr + 0xAD0, value);
            }
        }
        public float airAcceleration
        {
            get
            {
                return memory2.main.readFloat(addr + 0x8CC);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x8CC, value);
            }
        }

        public float X1
        {
            get
            {
                return memory2.main.readFloat(addr + 0x458);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x458, value);
            }
        }
        public float Y1
        {
            get
            {
                return memory2.main.readFloat(addr + 0x45C);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x45C, value);
            }
        }
        public float Z1
        {
            get
            {
                return memory2.main.readFloat(addr + 0x460);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x460, value);
            }
        }
        public float X2
        {
            get
            {
                return memory2.main.readFloat(addr + 0x464);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x464, value);
            }
        }
        public float Y2
        {
            get
            {
                return memory2.main.readFloat(addr + 0x468);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x468, value);
            }
        }
        public float Z2
        {
            get
            {
                return memory2.main.readFloat(addr + 0x46C);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x46C, value);
            }
        }
        public int isFalling
        {
            get
            {
                return memory2.main.readInt(addr + 0x194);
            }
            set
            {
                memory2.main.writeInt(addr + 0x194, value);
            }
        }
        public float velX
        {
            get
            {
                return memory2.main.readFloat(addr + 0x494);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x494, value);
            }
        }
        public float velY
        {
            get
            {
                return memory2.main.readFloat(addr + 0x498);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x498, value);
            }
        }
        public float velZ
        {
            get
            {
                return memory2.main.readFloat(addr + 0x49C);
            }
            set
            {
                memory2.main.writeFloat(addr + 0x49C, value);
            }
        }
        public float yaw
        {
            get
            {
                return memory2.main.readFloat(addr + 0xF4);
            }
            set
            {
                memory2.main.writeFloat(addr + 0xF4, value);
            }
        }
        public float pitch
        {
            get
            {
                return memory2.main.readFloat(addr + 0xF0);
            }
            set
            {
                memory2.main.writeFloat(addr + 0xF0, value);
            }
        }

        public byte heldItemCount
        {
            get
            {
                return memory2.main.readByte(addr + 0x225A);
            }
            set
            {
                memory2.main.writeByte(addr + 0x2102, value);
            }
        }

        public int heldItemID
        {
            get
            {
                return memory2.main.readInt(addr + 0x10E2);
            }
            set
            {
                memory2.main.writeInt(addr + 0x10E2, value);
            }
        }
        public bool inventoryIsOpen //Located near held item ID
        {
            get
            {
                return memory2.main.readInt(addr + 0x12BE) == 262144;
            }
        }
    }
}