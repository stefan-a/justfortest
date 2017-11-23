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
			steps {
				dir('src') {
					bat 'dotnet restore'
				}
			}
		}
		stage('Build'){
			tools {
				msbuild 'vs2017 MSBuild'
			}
			steps {
				dir('src'){
					bat '\"${msbuild} /t:rebuild\"'
					//bat 'dotnet build'
				}
			}
		}
	}
}