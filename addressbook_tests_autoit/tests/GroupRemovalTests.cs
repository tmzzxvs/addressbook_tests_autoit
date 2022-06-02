using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            if (oldGroups.Count == 1)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = GenerateRandomString(10)
                };
                app.Groups.Add(newGroup);
            }
            
            app.Groups.Remove();

            List<GroupData> newGroups = app.Groups.GetGroupList();

            
      //      oldGroups.Sort();
      //      newGroups.Sort();
      //      Assert.AreEqual(oldGroups, newGroups);
            




        }
    }
}