$Namespace = "unitaire"



$fileData = (Get-Content .\test\unitaire.yaml) -replace $Namespace, “production”
$fileData | Set-Content .\test\production.yaml
$fileData | kubectl apply -f - 

# $fileData = Get-Content .\test\deploy.yaml
# $fileData | kubectl apply -f -
kubectl apply -f .\test\deploy.yaml --namespace=production


write-host "Terminer"
