/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package learnlog4j;

import org.apache.log4j.Logger;
import org.apache.log4j.xml.DOMConfigurator;

/**
 *
 * @author TOSHIBA
 */
public class LearnLog4J {

    private static Logger log = Logger.getLogger(LearnLog4J.class);

    public static void main(String args[]) {
        DOMConfigurator.configure("log4j.xml");

        log.info("This is info message");
    }

}
