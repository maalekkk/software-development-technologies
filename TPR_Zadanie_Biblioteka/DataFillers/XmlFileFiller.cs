﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DL.DataFillers
{
    class XmlFileFiller : IDataFiller
    {
        public LibraryContext Fill(string path)
        {
            LibraryContext libraryContext = new LibraryContext();
            XmlReader xmlReader = XmlReader.Create(path);
            while (xmlReader.Read())
            {

            }


            return libraryContext;
        }
    }
}