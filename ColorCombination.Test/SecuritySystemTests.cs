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

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();
           
            string expectedOutput = TestData.FailureOutput;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }


        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_ValidFailure()
        {
            // Setup
            List<MyChip> chips = TestData.Failure1;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            string expectedOutput = TestData.FailureOutput;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);            
        }


        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Success1()
        {
            // Setup
            List<MyChip> chips = TestData.Success1;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            string expectedOutput = TestData.SuccessExpectedOutput1;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }
        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Success1()
        {
            // Setup
            List<MyChip> chips = TestData.Success1;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            string expectedOutput = TestData.SuccessExpectedOutput1;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Success2()
        {
            // Setup
            List<MyChip> chips = TestData.Success2;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            string expectedOutput = TestData.SuccessExpectedOutput2;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }
        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Success2()
        {
            // Setup
            List<MyChip> chips = TestData.Success2;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            string expectedOutput = TestData.SuccessExpectedOutput2;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }
        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Fail2()
        {
            // Setup
            List<MyChip> chips = TestData.Failure2;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            string expectedOutput = TestData.FailureOutput;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }
        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Fail2()
        {
            // Setup
            List<MyChip> chips = TestData.Failure2;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            string expectedOutput = TestData.FailureOutput;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Success3()
        {
            // Setup
            List<MyChip> chips = TestData.Success3;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            string expectedOutput = TestData.SuccessExpectedOutput3;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Success3()
        {
            // Setup
            List<MyChip> chips = TestData.Success3;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            string expectedOutput = TestData.SuccessExpectedOutput3;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombinationByG_Fail3()
        {
            // Setup
            List<MyChip> chips = TestData.Failure3;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombinationByG();

            string expectedOutput = TestData.FailureOutput;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }

        [TestMethod]
        public void TestSecuritySys_FindMasterCombination_Fail3()
        {
            // Setup
            List<MyChip> chips = TestData.Failure3;

            // Execute Test
            SecuritySystem mySystem = new SecuritySystem(chips);
            string actualOutput = mySystem.FindMasterCombination();

            string expectedOutput = TestData.FailureOutput;

            // Asserts
            Assert.AreEqual<string>(expectedOutput, actualOutput);

        }

    }
}
