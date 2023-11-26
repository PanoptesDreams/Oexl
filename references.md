# Table of contents

### Incremental version numbers for builds

Only have the following in 'AssemblyInfo.vb'
'<Assembly: AssemblyVersion("0.1.*")>'
and not
'<Assembly: AssemblyFileVersion("0.1.*")>'
otherwise builds won't have proper versioning.
That said we don't like VS/MS's versioning either.
Also 
    <Deterministic>false</Deterministic>
in '.vbproj' file
https://stackoverflow.com/questions/826777/how-to-have-an-auto-incrementing-version-number-visual-studio

### Web Access

'Imports System.Net' is the solution found here
http://vb-helper.com/howto_net_download_file.html