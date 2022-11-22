// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("ZddUd2VYU1x/0x3TolhUVFRQVVa4dCTGUA9c5b5qcKKeX8232zYga7zfVjhCEzaRAoktCf50z9lh0vJwjgTk/FpFsRKc+tnQ91zZq4aYjtCmx/7FzH0+MUWCHyODcy9micElnGRjKvIGbmeiap1xhY9QJYK+I5tRPARNlE9MgrL9EiNa+RoWsXNPUb4AcKp7tu4LhnBPgdSQMf9L+2QLINdUWlVl11RfV9dUVFXxzM4rVAYunnAxt03lEyE+9S3XCMJeJOZ/HWON6JdBnhLfw59vTu1SkfQnwzLz+d/W9pEf5/7oZ2RHsEAcZhemVJjPnT3FWIMbgyO/sy0yDVvj4VTfKxRwB101GZ+S3gjFDAXnRPwIqC30EnsE1dwN2R6AnldWVFVU");
        private static int[] order = new int[] { 0,10,6,4,4,11,8,13,10,9,12,12,12,13,14 };
        private static int key = 85;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
