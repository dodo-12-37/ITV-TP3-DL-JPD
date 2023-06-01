$Namespace_aModifier = "NAMESPACE"
$NodePort_aModifier = 4441919

$Namespace_list = "unitaire", "acceptation", "production"   #[string[]]
$NodePort_list = 30000, 30001, 30002    #[int[]] 
$volumePath = "C:\itv\ITV-TP3-DL-JPD\persistence"



$i = 0
foreach ($Namespace in $Namespace_list) {
    write-host ""
    write-host "--- Démarrage des déploiements : $Namespace ---"

    if (Test-Path "$volumePath\$Namespace") {
        # Folder exists - Do something here
        Write-host "Le dossier existe ! : $volumePath\$Namespace" -f Green
    }
    else {
        # Folder does not exist - Do something else here
        # Write-host "Le dossier n'existe pas !" -f Red
        New-Item -Path "$volumePath\$Namespace" -ItemType Directory
        Write-host "Le dossier est créer ! : $volumePath\$Namespace" -f Green
    }

    $fileData = (Get-Content .\deploy\config.yaml) -creplace $Namespace_aModifier, $Namespace -creplace $NodePort_aModifier, $NodePort_list[$i]
    $fileData | Set-Content .\deploy\fichiersCreer\$Namespace.yaml    # Uniquement pour visualiser les fichiers résultants
    $fileData | kubectl apply -f - 
    $i++
}

write-host ""
write-host "Terminer"
write-host ""


# while [[ $(kubectl get pods -l app=hello -o 'jsonpath={..status.conditions[?(@.type=="Ready")].status}') != "True" ]]; do echo "waiting for pod" && sleep 1; done