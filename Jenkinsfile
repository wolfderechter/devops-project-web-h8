node('AcceptatieServer') {  
    stage('Build') { 
        build 'dotnet_test'
    }
    stage('Deploy') { 
        build 'Acceptatie_cleanup'
        build 'Acceptatie_pull_github' 
        build 'Acceptatie_inject_dockerfiles' 
        build 'Acceptatie_buildWebApp'
    }
}
