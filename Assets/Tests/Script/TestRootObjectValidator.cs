using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using Script;

namespace Tests.Script
{
    public class TestRootObjectValidator
    {
        [SetUp]
        public void SetUp()
        {
            _rootObject = new GameObject("RootObject");

            _childObject = new GameObject("ChildObject");
            _childObject.transform.SetParent(_rootObject.transform, worldPositionStays: false);
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(_childObject);
            Object.DestroyImmediate(_rootObject);
        }

        [Test]
        public void Validate_ReturnsTrueIfRootObject()
        {
            var target = _rootObject.AddComponent<RootObjectValidator>();
            Assert.True(target.Validate());
        }

        [Test]
        public void Validate_ReturnsFalseIfNotRootObject()
        {
            var target = _childObject.AddComponent<RootObjectValidator>();
            Assert.False(target.Validate());
        }

        GameObject _rootObject;
        GameObject _childObject;
    }
}
