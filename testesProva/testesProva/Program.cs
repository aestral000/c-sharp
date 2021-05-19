using System;
using System.Collections.Generic;
using System.IO;

namespace Solution {
    
    public class Note {
        private string _state;
        private string _name;

        public Note() { }

        public string  Name {
            get{ return _name; }
            set{
                if (!String.IsNullOrEmpty(value)) {
                    this._name = value;
                }
                else {
                    throw new Exception("Name cannot be Empty");
                }
            }
        }

        public string State {
            get{ return _state; }
            set{
                if (value.Equals("active")) {
                    this._state = value;
                }
                else if (value.Equals("completed")) {
                    this._state = value;
                }
                else if (value.Equals("others")) {
                    this._state = value;
                }
                else {
                    throw new Exception("Invalid state "+ value);
                }
            }
        }


    }
    public class NotesStore {

        private List<Note> _list;
        public NotesStore() {
            this._list = new List<Note>();
        }


        public void AddNote(String state, String name) {

            if (state != null || name != null) {
                Note note = new Note();
                note.Name = name;
                note.State = state;

                _list.Add(note);

            }



        }
        public List<String> GetNotes(String state) {
            if (state != null) {
                List<String> names = new List<String>();
                if (state.Equals("active")) {
                    foreach (Note n in _list) {
                        if (state.Equals("active")) {
                            names.Add(n.Name);
                        }
                    }
                    return names;
                }
                else if (state.Equals("completed")) {
                    foreach (Note n in _list) {
                        if (state.Equals("completed")) {
                            names.Add(n.Name);
                        }
                    }

                    return names;
                }
                else if (state.Equals("others")) {
                    foreach (Note n in _list) {
                        if (state.Equals("others")) {
                            names.Add(n.Name);
                        }
                    }

                    return names;
                }
                else {
                    throw new Exception(String.Format("Invalid state {0}",state));
                }
            }
            return null;
        }
    }
    public class Solution {
        public static void Main() {
            //var notesStoreObj = new NotesStore();
            //var n = int.Parse(Console.ReadLine());
            //for (var i = 0; i < n; i++) {
            //    var operationInfo = Console.ReadLine().Split(' ');
            //    try {
            //        if (operationInfo[0] == "AddNote")
            //            notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
            //        else if (operationInfo[0] == "GetNotes") {
            //            var result = notesStoreObj.GetNotes(operationInfo[1]);
            //            if (result.Count == 0)
            //                Console.WriteLine("No Notes");
            //            else
            //                Console.WriteLine(string.Join(",", result));
            //        }
            //        else {
            //            Console.WriteLine("Invalid Parameter");
            //        }
            //    }
            //    catch (Exception e) {
            //        Console.WriteLine("Error: " + e.Message);
            //    }
            //}

            NotesStore n = new NotesStore();

            n.AddNote("active", "Drink");

            Console.WriteLine(n.GetNotes("active").Count);
        }
    }
}