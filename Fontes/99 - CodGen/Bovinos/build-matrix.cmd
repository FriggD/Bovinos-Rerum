echo off
set GENHOME=.\generated
set CSRPO=%GENHOME%\cs_rpo
set CSRPO_TEST=%GENHOME%\cs_rpo_test
set DOMSQL=%GENHOME%\dom_sql
set BOSFACTORY=%GENHOME%\bosfactory
set LIBNAME=Bovinos

del /s/q %CSRPO%
del /s/q %CSRPO_TEST%
del /s/q %DOMSQL%
del /s/q %BOSFACTORY%

rd /s/q %CSRPO%
rd /s/q %CSRPO_TEST%
rd /s/q %DOMSQL%
rd /s/q %BOSFACTORY%

mkdir %CSRPO%
mkdir %CSRPO_TEST%
mkdir %DOMSQL%
mkdir %BOSFACTORY%

rem Insira abaixo as rotinas para copiar os arquivos antes da geracao
rem Voce pode usar as variaveis GWTMODEL, GWTUI, CSRPO, CSCONV para obter
rem a localizacao das pastas de destino onde seram criados os arquivos
rem bucb: Pre-Gen
set SRCROOT=..\..
set PastaLibs="%SRCROOT%\01 - Negocios\%LIBNAME%"
set PastaTests="%SRCROOT%\49 - Testes\TesteBovinos"

echo xcopy /s/y %PastaLibs% to %CSRPO%\%LIBNAME%\
mkdir %CSRPO%\%LIBNAME%\
xcopy /s/y/i %PastaLibs%\*.cs %CSRPO%\%LIBNAME%\

echo xcopy /s/q %PastaTests% to %CSRPO_TEST%
xcopy /s/y/i %PastaTests%\*.cs %CSRPO_TEST%\

IF "%1" == "PostGen" GOTO PostGen
rem eucb: Pre-Gen

IF "%1" == "" GOTO BuildAll

rem Indica em qual classe deve parar
set STOP=%1

IF "%1" == "Animal" GOTO LBL_Animal
IF "%1" == "trn_Animal" GOTO LBL_trn_Animal
IF "%1" == "evt_CadastraAnimal" GOTO LBL_evt_CadastraAnimal
IF "%1" == "evt_ConsultarAnimal" GOTO LBL_evt_ConsultarAnimal
IF "%1" == "evt_EditarAnimal" GOTO LBL_evt_EditarAnimal
IF "%1" == "evt_ListarAnimais" GOTO LBL_evt_ListarAnimais
IF "%1" == "evt_RemoverAnimal" GOTO LBL_evt_RemoverAnimal

:BuildAll
echo Transacoes

:LBL_trn_Animal

rem Gerando arquivos para Animal
call amcg --nb --o %CSRPO%\Bovinos\application\trn\\TRNAnimal.cs --code-model .\model\\trn_Animal.js --template ..\templates\Transacao\Trn.cs -Drvo_targetLib=Bovinos
call amcg --nb --o %CSRPO_TEST%\Bovinos\application\trn\test\\TRNAnimalTest.cs --code-model .\model\\trn_Animal.js --template ..\templates\Transacao\TestTrn.cs -Drvo_targetLib=Bovinos


echo Trn Bovinos/Animal // OK

IF "%STOP%" == "trn_Animal" GOTO PostGen

echo Events
:LBL_evt_CadastraAnimal

rem Gerando arquivos para CadastraAnimal
rem Events
call amcg --nb --o %CSRPO%\Bovinos\application\evt\\EvCadastraAnimal.cs --code-model .\model\\evt_CadastraAnimal.js --template ..\templates\Transacao\Event.cs -Drvo_targetLib=Bovinos


echo Event: Bovinos/EvCadastraAnimal // OK

IF "%STOP%" == "evt_CadastraAnimal" GOTO PostGen
rem LBL_evt_${transactionName}_CadastraAnimal
:LBL_evt_ConsultarAnimal

rem Gerando arquivos para ConsultarAnimal
rem Events
call amcg --nb --o %CSRPO%\Bovinos\application\evt\\EvConsultarAnimal.cs --code-model .\model\\evt_ConsultarAnimal.js --template ..\templates\Transacao\Event.cs -Drvo_targetLib=Bovinos


echo Event: Bovinos/EvConsultarAnimal // OK

IF "%STOP%" == "evt_ConsultarAnimal" GOTO PostGen
rem LBL_evt_${transactionName}_ConsultarAnimal
:LBL_evt_EditarAnimal

rem Gerando arquivos para EditarAnimal
rem Events
call amcg --nb --o %CSRPO%\Bovinos\application\evt\\EvEditarAnimal.cs --code-model .\model\\evt_EditarAnimal.js --template ..\templates\Transacao\Event.cs -Drvo_targetLib=Bovinos


echo Event: Bovinos/EvEditarAnimal // OK

IF "%STOP%" == "evt_EditarAnimal" GOTO PostGen
rem LBL_evt_${transactionName}_EditarAnimal
:LBL_evt_ListarAnimais

rem Gerando arquivos para ListarAnimais
rem Events
call amcg --nb --o %CSRPO%\Bovinos\application\evt\\EvListarAnimais.cs --code-model .\model\\evt_ListarAnimais.js --template ..\templates\Transacao\Event.cs -Drvo_targetLib=Bovinos


echo Event: Bovinos/EvListarAnimais // OK

IF "%STOP%" == "evt_ListarAnimais" GOTO PostGen
rem LBL_evt_${transactionName}_ListarAnimais
:LBL_evt_RemoverAnimal

rem Gerando arquivos para RemoverAnimal
rem Events
call amcg --nb --o %CSRPO%\Bovinos\application\evt\\EvRemoverAnimal.cs --code-model .\model\\evt_RemoverAnimal.js --template ..\templates\Transacao\Event.cs -Drvo_targetLib=Bovinos


echo Event: Bovinos/EvRemoverAnimal // OK

IF "%STOP%" == "evt_RemoverAnimal" GOTO PostGen
rem LBL_evt_${transactionName}_RemoverAnimal

echo Objects
:LBL_Animal

rem Gerando arquivos para Animal
rem BosCol
call amcg --nb --o %CSRPO%\Bovinos\application\bos\Animal.cs --code-model .\model\Animal.js --template ..\templates\BosCol\Bos.cs -Drvo_targetLib=Bovinos

call amcg --nb --o %CSRPO%\Bovinos\application\col\\ColAnimal.cs --code-model .\model\Animal.js --template ..\templates\BosCol\Col.cs -Drvo_targetLib=Bovinos
call amcg --nb --o %BOSFACTORY%\Bovinos\Animal.sql --code-model .\model\Animal.js --template ..\templates\BosCol\BosFactory.txt -Drvo_targetLib=Bovinos

echo Bos/Col Bovinos/Animal // OK


IF "%STOP%" == "Animal" GOTO PostGen
rem END LBL_Animal

echo TAD

echo Domain

echo Test Suite

:PostGen
rem bucb: Post-Gen
echo xcopy /s/y %CSRPO%\%LIBNAME% to %PastaLibs%\
xcopy /s/y %CSRPO%\%LIBNAME% %PastaLibs%\

echo xcopy /s/q %CSRPO_TEST% to %PastaTests%\
xcopy /s/y %CSRPO_TEST% %PastaTests%\
rem eucb: Post-Gen

:end
echo on
