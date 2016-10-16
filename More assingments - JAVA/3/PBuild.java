/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pbuild;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.lang.management.OperatingSystemMXBean;
import java.lang.management.RuntimeMXBean;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

/**
 *
 * @author user
 */
public class PBuild {

    public void displayAvailableProcessors() {

    Runtime runtime = Runtime.getRuntime();
    
    OperatingSystemMXBean operatingSystemMXBean =
    java.lang.management.ManagementFactory.getOperatingSystemMXBean();
    
    RuntimeMXBean runtimeMXBean = java.lang.management.ManagementFactory.getRuntimeMXBean();
    
    int nrOfProcessors = runtime.availableProcessors();
    String osArch = operatingSystemMXBean.getArch();
    String osName = operatingSystemMXBean.getName();
    String osVersion = operatingSystemMXBean.getVersion();
    String vmName = runtimeMXBean.getName();
    String vmVer = runtimeMXBean.getSpecVersion();
    String vmSpec = runtimeMXBean.getSpecName();
    
    System.out.println("Number of processors: " + nrOfProcessors + "\nOS arch: " + osArch + "\nOS name: " + osName + "\nOS version: " + osVersion + "\nVM name: " + vmName + "\nVM Spec: " + vmSpec + "\nVM SpecVersion: " + vmVer);

 }
    public static void main(String[] args) throws IOException {
        new PBuild().displayAvailableProcessors();
        
        if (args.length != 1) {
            System.out.println("Usage: java OSProcess <command>");
            System.exit(0);
        }
        
        // args[0] is the command
        ProcessBuilder pb = new ProcessBuilder(args[0]);
        Process proc = pb.start();

        // obtain the input stream
        InputStream is = proc.getInputStream();
        InputStreamReader isr = new InputStreamReader(is);
        BufferedReader br = new BufferedReader(isr);

        // read what is returned by the command
        String line;
        while ((line = br.readLine()) != null) {
            System.out.println(line);
        }
        br.close();
        }
    
}
