# SFE v0.2
"Simple File Encryption" is a Class that work with Bytes of a file and manipulate them to make them unreadable by system.
It's simple (as the name says:joy:) to use, so have fun with it .

### Encrypt File:
```javascript
string path = @"C:\somefile.ext";
SFE sfe = new SFE();
byte[] a = sfe.GetBytes(path);
byte[] b = sfe.Encrypt(a);
sfe.SaveFile(@"C:\encryptedFile.ext",b);
```

### Decrypt File:
```javascript
string path = @"C:\encryptedFile.ext";
SFE sfe = new SFE();
byte[] a = sfe.GetBytes(path);
byte[] b = sfe.Decrypt(a);
sfe.SaveFile(@"C:\decryptedFile.ext", b);
```
