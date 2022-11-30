using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CommonLib.Messages
{
    public class ObjectToken: IEquatable<ObjectToken>
    {
        object obj;
        public ObjectToken(object obj)
        {
            this.obj = obj;
        }
        public ObjectToken()
        {
            this.obj = new object();
        }
        public bool Equals([AllowNull] ObjectToken other)
        {
            if (obj == null || other?.obj == null) { return false; }
            return obj == other.obj;
        }
        public override int GetHashCode()
        {
            return obj.GetHashCode();
        }

    }
}
