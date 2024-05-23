﻿using Common.Proto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Tool
{
    public static class VectorHelper
    {
        /// <summary>
        /// 方向向量转欧拉角
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public static Vector3 ToEulerAngles(this Vector3 direction)
        {
            const float rad2Deg = 57.29578f;
            var num = MathF.Sqrt(
                (direction.X * direction.X + direction.Z * direction.Z) /
                (direction.X * direction.X + direction.Y * direction.Y + direction.Z * direction.Z)
            );
            var eulerAngles = new Vector3
            {
                // Anglex = arc cos(sqrt((x^2 + z^2) / (x^2 + y^2 + z^2)))
                X = MathF.Acos(num) * rad2Deg
            };

            if (direction.Y > 0) eulerAngles.X = 360 - eulerAngles.X;

            // AngleY = arc tan(x/z)
            eulerAngles.Y = MathF.Atan2(direction.X, direction.Z) * rad2Deg;
            if (eulerAngles.Y < 0) eulerAngles.Y += 180;
            if (direction.X < 0) eulerAngles.Y += 180;

            // AngleZ = 0
            eulerAngles.Z = 0;
            return eulerAngles;
        }

        public static Vector3 Normalized(this Vector3 value)
        {
            var length = (float)Math.Sqrt((double)value.X * (double)value.X + 
                                          (double)value.Y * (double)value.Y + 
                                          (double)value.Z * (double)value.Z);
            if (length > 1E-05f)
            {
                return value / length;
            }
            return Vector3.Zero;
        }

        public static Vector2 ToVector2(this Vector3 vector3)
        {
            var vector2 = new Vector2(vector3.X, vector3.Z);
            return vector2;
        }
    }
}
