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
            if (app.Groups.GetGroupList().Count == 1)
            {
                app.Groups.Add(new GroupData() { Name = GenerateRandomString(10) });
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove();

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups.Count, newGroups.Count);
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}