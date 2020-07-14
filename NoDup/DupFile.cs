using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace NoDup
{
    class DupFile
    {
        // id of group of files
        public long Group;
        // hash of relevant attributes
        public string AttribHash;

        public string Name;
        public string Path;
        public long Size;
        public DateTime Created;
        public DateTime Modified;
        public string ContentsHash;
        public bool Delete;

        public DupFile()
        {
            this.Group = 0;
            this.Delete = false;
        }

        // builds a string out of all the components then computes the hash of that string
        public void ComputeHash(bool Name, bool Size, bool Date, bool Contents)
        {
            var objMD5 = MD5.Create();
            string AttribStr = "";
            if (Name) AttribStr += this.Name;
            if (Size) AttribStr += this.Size;
            if (Date) AttribStr += this.Created;
            if (Date) AttribStr += this.Modified;
            if (Contents) // to be verified
            {
                var objStream = File.OpenRead(this.Path + "\\" + this.Name);
                this.ContentsHash = BitConverter.ToString(objMD5.ComputeHash(objStream)).Replace("-", "");
                AttribStr += this.ContentsHash;
            }
            byte[] tmp = Encoding.ASCII.GetBytes(AttribStr);
            this.AttribHash = BitConverter.ToString(objMD5.ComputeHash(tmp)).Replace("-","");
        }
    }
}
