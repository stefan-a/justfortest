pipeline {
  agent any
  stages {
    stage('Step 1') {
      steps {
        parallel(
          "Step 1": {
            echo 'Hello to you all!'
            
          },
          "Fetch Code": {
            git(url: 'https://github.com/stefan-a/justfortest', branch: 'master', changelog: true)
            
          }
        )
      }
    }
  }
}