using DungeonResource.Test.Components.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Test.Components.Service
{
    public class TestObjectService
    {
        public TestObject GetTestObject()
        {
            return new TestObject
            {
                Title = "Test Title",
                Description = "Test Description"
            };
        }

        public List<TestObject> GetTestObjectCollection(int count = 10)
        {
            var testObjects = new List<TestObject>();

            for (int x = 0; x < count; x++)
            {
                testObjects.Add(GetTestObject());
            }

            return testObjects;
        }
    }
}
