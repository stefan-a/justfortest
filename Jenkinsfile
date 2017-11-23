#!/usr/bin/env groovy
pipeline{
	agent any
	stages {
		stage('checkout'){
			steps{
				checkout(
					[$class: 'GitSCM', branches: [[name: '*/master']], 
					doGenerateSubmoduleConfigurations: false, 
					extensions: [], 
					submoduleCfg: [], 
					userRemoteConfigs: [[credentialsId: 'GitHub', url: 'https://github.com/stefan-a/justfortest']]
					]
				)
			}
		}
		stage('Prepare for build'){
			tools {
				msbuild 'vs2017 MSBuild'
			}
			steps {
				dir('src') {
					bat 'dotnet restore'
				}
			}
		}
	}
}
// pipeline {
//   agent any
//   stages {
//     stage('Step 1') {
//       steps {
//         parallel(
//           "Step 1": {
//             echo 'Hello to you all!'
//             
//           },
//           "Fetch Code": {
//             git(url: 'https://github.com/stefan-a/justfortest', branch: 'master', changelog: true)
//           }
//         )
//       }
//     }
//   }
// }