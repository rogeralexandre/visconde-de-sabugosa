using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CShp_SecureString
{
    public class TratandoStringSegura
    {
        public static SecureString ConverterParaSecureString(string strSenha)
        {
            SecureString stringSegura = null;
            try
            {
                stringSegura = new SecureString();
                if ((strSenha.Length > 0))
                {
                    foreach (Char caractere in strSenha.ToCharArray())
                    {
                        stringSegura.AppendChar(caractere);
                    }
                }
                return stringSegura;
            }
            catch
            {
                throw;
            }
        }

        public static string LerSecureString(SecureString secure)
        {
            IntPtr unmanagedPtr = IntPtr.Zero;

            try
            {
                if (secure == null)
                    throw new ArgumentNullException("String Segura não definida");

                unmanagedPtr =  Marshal.SecureStringToGlobalAllocUnicode(secure);
                return Marshal.PtrToStringUni(unmanagedPtr);
            }
            catch 
            {
                throw;
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedPtr);
                secure.Dispose();
            }
        }
    }
}
