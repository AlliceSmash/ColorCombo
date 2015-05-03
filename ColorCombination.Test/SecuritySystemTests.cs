using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorCombination.Test
{
    [TestClass]
    public class SecuritySystemTests
    {
        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_ValidFailure()
        {
            // Setup
            List<MyChip> chips = TestData.Failure1;
            string expectedOutput = TestData.FailureOutput;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }


        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_ValidFailure()
        {
            // Setup
            List<MyChip> chips = TestData.Failure1;
            string expectedOutput = TestData.FailureOutput;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }


        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Success1()
        {
            // Setup
            List<MyChip> chips = TestData.Success1;
            string expectedOutput = TestData.SuccessExpectedOutput1;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Success1()
        {
            // Setup
            List<MyChip> chips = TestData.Success1;
            string expectedOutput = TestData.SuccessExpectedOutput1;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Success2()
        {
            // Setup
            List<MyChip> chips = TestData.Success2;
            string expectedOutput = TestData.SuccessExpectedOutput2;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Success2()
        {
            // Setup
            List<MyChip> chips = TestData.Success2;
            string expectedOutput = TestData.SuccessExpectedOutput2;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Fail2()
        {
            // Setup
            List<MyChip> chips = TestData.Failure2;
            string expectedOutput = TestData.FailureOutput;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Fail2()
        {
            // Setup
            List<MyChip> chips = TestData.Failure2;
            string expectedOutput = TestData.FailureOutput;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Success3()
        {
            // Setup
            List<MyChip> chips = TestData.Success3;
            string expectedOutput = TestData.SuccessExpectedOutput3;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Success3()
        {
            // Setup
            List<MyChip> chips = TestData.Success3;
            string expectedOutput = TestData.SuccessExpectedOutput3;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Fail3()
        {
            // Setup
            List<MyChip> chips = TestData.Failure3;
            string expectedOutput = TestData.FailureOutput;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Fail3()
        {
            // Setup
            List<MyChip> chips = TestData.Failure3;
            string expectedOutput = TestData.FailureOutput;

            // Action
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            // Assert
            Assert.AreEqual<string>(expectedOutput, actualOutput);
        }
    }
}
