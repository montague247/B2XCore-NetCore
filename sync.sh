#!/bin/bash
echo Start syncing...

SOURCEPATH=../B2XCore/Libs/B2XCore.Types/
TARGETPATH=Libs-B2XCore/B2XCore.Types-NetCore/
rsync -uhcrvz --progress --stats $SOURCEPATH $TARGETPATH
rsync -uhcrvz --progress --stats $TARGETPATH $SOURCEPATH

echo End syncing

svn commit -m "synced" ../B2XCore/

