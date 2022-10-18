import fs from 'node:fs'
import path, { dirname } from 'node:path'
import { program, Option } from 'commander';
import { rm, mv, exec } from "@puerts/shell-util"
import { fileURLToPath } from 'node:url';
const pwd = process.cwd();
const __dirname = dirname(fileURLToPath(import.meta.url));
if (!fs.existsSync(`${pwd}/package.json`) || !fs.existsSync(`${pwd}/Packages`)) {
    console.error("[Puer] invalid directory, please run in the root of PerformanceTesting");
    process.exit(1);``
}
if (!fs.existsSync(`${pwd}/node_modules`)) {
    console.log("[Puer] installing node_modules");
    require('child_process').execSync('npm i')
}


////////////////////////////////////////////////////
program.requiredOption("--unity <profileOrPath>", "The Unity binary")
program.requiredOption("--pkg <pkg>", "The path of puerts package")
program.parse()
const options = program.opts();

///////////////////////////////////////////////////
(async function () {
    console.log("[Puer] finding unity");
    let unityPath = options.unity;
    
    const upmSetting = JSON.parse(fs.readFileSync(`${__dirname}/../Packages/manifest.json`))
    let use = `file:../${options.pkg}`
    console.log("[Puer] changing puerts to: " + use);
    upmSetting.dependencies['com.tencent.puerts.core'] = use;
    fs.writeFileSync(`${__dirname}/../Packages/manifest.json`, JSON.stringify(upmSetting));
    
    console.log("[Puer] Generating Wrapper");
    rm("-rf", `${pwd}/Assets/Gen`);
    rm("-rf", `${pwd}/Assets/Gen.meta`);
    rm("-rf", `${pwd}/Assets/XLua/Gen`);
    rm("-rf", `${pwd}/Assets/XLua/Gen.meta`);
    rm("-rf", `${pwd}/STATES.md`);
    
    rm("-rf", `${pwd}/build`)
    await exec(`${unityPath} -batchmode -quit -projectPath "${pwd}" -executeMethod CommandLineTests.GenCode -logFile "log.txt"`);
    rm("-rf", `${pwd}/Library/ScriptAssemblies`);
    console.log("[Puer] Building");
    let buildArg = "";
    if (process.platform == 'darwin') {
        buildArg = '-buildOSXUniversalPlayer ./build/mac.app'

    } else if (process.platform == 'win32') {
        buildArg = '-buildWindows64Player ./build/win.exe'
    }
    await exec(`${unityPath} -batchmode -quit -projectPath "${pwd}" ${buildArg} -logFile "log.txt"`);
})().catch(err=> {
    console.log(`error occured! code: ${err.message}. please view log.txt`);
});