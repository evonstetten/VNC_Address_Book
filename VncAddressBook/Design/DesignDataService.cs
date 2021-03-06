﻿using System;
using System.Collections.Generic;
using VncAddressBook.Model;
using VncAddressBook.Models;

namespace VncAddressBook.Design
{
    public class DesignDataService : IDataService
    {
        public void SaveConfig(Config config)
        {
            throw new NotImplementedException();
        }

        public Config LoadConfig()
        {
            throw new NotImplementedException();
        }

        public void SaveEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public List<Entry> LoadEntries()
        {
            return new List<Entry>()
                {
                    new Entry()
                    {
                        Name = "WS0001 - Ethan Office",
                        Host = "192.168.1.1"
                    },
                    new Entry()
                    {
                        Name = "WS0001 - Warehouse",
                        Host = "192.168.1.3"
                    }
                };
        }

        public void OpenVncViewer(Entry entry)
        {
            throw new NotImplementedException();
        }

        public void ShowMessageBox(string s, Action<bool> callback)
        {
            throw new NotImplementedException();
        }
    }
}