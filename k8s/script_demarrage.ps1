$Namespace = "NAMESPACE"
# $NodePort = NODEPORT
$NodePort = 4441919


$fileData = (Get-Content .\unitaire\nouveauConfig.yaml) -creplace $Namespace, “production” -creplace $NodePort, "30002"
$fileData | Set-Content .\unitaire\nouveauProduction.yaml
$fileData | kubectl apply -f - 

# $fileData = Get-Content .\test\deploy.yaml
# $fileData | kubectl apply -f -
# kubectl apply -f .\test\deploy.yaml --namespace=production


write-host "Terminer"
